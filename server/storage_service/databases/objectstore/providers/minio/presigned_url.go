package minio

import (
	"context"

	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/aws/aws-sdk-go/aws"
	"github.com/aws/aws-sdk-go/aws/credentials"
	"github.com/aws/aws-sdk-go/aws/session"
	"github.com/aws/aws-sdk-go/service/s3"
)

const (
	uploadUrlOperation = "PUT"

	downloadUrlOperation = "GET"
)

func PublicCon() (*s3.S3, error) {
	publicUrl := memorystore.RequiredEnvStoreObj.GetRequiredEnv().PublicUrl
	accessKey := memorystore.RequiredEnvStoreObj.GetRequiredEnv().AccessKey
	secretKey := memorystore.RequiredEnvStoreObj.GetRequiredEnv().SecretKey
	useSsl := memorystore.RequiredEnvStoreObj.GetRequiredEnv().UseSsl
	awsRegion := memorystore.RequiredEnvStoreObj.GetRequiredEnv().AwsRegion

	publicConConfig := &aws.Config{
		Credentials:      credentials.NewStaticCredentials(accessKey, secretKey, ""),
		Endpoint:         aws.String(publicUrl),
		Region:           aws.String(awsRegion),
		DisableSSL:       aws.Bool(useSsl),
		S3ForcePathStyle: aws.Bool(true),
	}

	publicSession, err := session.NewSession(publicConConfig)
	if err != nil {
		return nil, err
	}

	publicCon := s3.New(publicSession)

	return publicCon, nil
}

func (p *provider) CreatePreassignedPutUrl(ctx context.Context, presignedPutUrl models.PresignedPutUrlInput) (*models.PresignedUrl, error) {
	expiry := memorystore.RequiredEnvStoreObj.GetRequiredEnv().PresignedPutUrlExpiry

	publicCon, err := PublicCon()
	if err != nil {
		return nil, err
	}

	request, _ := publicCon.PutObjectRequest(&s3.PutObjectInput{
		Bucket: &presignedPutUrl.BucketName,
		Key:    &presignedPutUrl.ObjectName,
	})

	presignedUrl, err := request.Presign(expiry)
	if err != nil {
		return nil, err
	}

	return &models.PresignedUrl{
		ObjectName:   presignedPutUrl.ObjectName,
		Url:          presignedUrl,
		UrlOperation: uploadUrlOperation,
		Bucket:       presignedPutUrl.BucketName,
		Path:         presignedPutUrl.BucketName + "/" + presignedPutUrl.ObjectName,
		Expiry:       expiry.String(),
	}, nil
}

func (p *provider) CreatePreassignedGetUrl(ctx context.Context, presignedGetUrl models.PresignedGetUrlInput) (*models.PresignedUrl, error) {
	expiry := memorystore.RequiredEnvStoreObj.GetRequiredEnv().PresignedGetUrlExpiry

	publicCon, err := PublicCon()
	if err != nil {
		return nil, err
	}

	request, _ := publicCon.GetObjectRequest(&s3.GetObjectInput{
		Bucket: &presignedGetUrl.BucketName,
		Key:    &presignedGetUrl.ObjectName,
	})

	presignedUrl, err := request.Presign(expiry)
	if err != nil {
		return nil, err
	}

	return &models.PresignedUrl{
		ObjectName:   presignedGetUrl.ObjectName,
		Url:          presignedUrl,
		UrlOperation: downloadUrlOperation,
		Bucket:       presignedGetUrl.BucketName,
		Path:         presignedGetUrl.BucketName + "/" + presignedGetUrl.ObjectName,
		Expiry:       expiry.String(),
	}, nil
}
