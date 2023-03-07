package minio

import (
	"fmt"

	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/aws/aws-sdk-go/aws"
	"github.com/aws/aws-sdk-go/aws/credentials"
	"github.com/aws/aws-sdk-go/aws/session"
	"github.com/aws/aws-sdk-go/service/s3"

	log "github.com/sirupsen/logrus"
)

type provider struct {
	objectDb *s3.S3
}

func NewProvider() (*provider, error) {
	var err error

	url := memorystore.RequiredEnvStoreObj.GetRequiredEnv().ObjectStoreUrl
	accessKey := memorystore.RequiredEnvStoreObj.GetRequiredEnv().AccessKey
	secretKey := memorystore.RequiredEnvStoreObj.GetRequiredEnv().SecretKey
	useSsl := memorystore.RequiredEnvStoreObj.GetRequiredEnv().UseSsl
	awsRegion := memorystore.RequiredEnvStoreObj.GetRequiredEnv().AwsRegion
	objectLocking := memorystore.RequiredEnvStoreObj.GetRequiredEnv().ObjectLocking

	s3config := &aws.Config{
		Credentials:      credentials.NewStaticCredentials(accessKey, secretKey, ""),
		Endpoint:         aws.String(url),
		Region:           aws.String(awsRegion),
		DisableSSL:       aws.Bool(useSsl),
		S3ForcePathStyle: aws.Bool(true),
	}

	s3session, err := session.NewSession(s3config)
	if err != nil {
		log.Error("Error initializing s3 client : ", err)
		return nil, err
	}

	s3client := s3.New(s3session)

	bucketNames := memorystore.RequiredEnvStoreObj.GetRequiredEnv().BucketNames

	for _, bucketName := range bucketNames {
		err, _ := s3client.CreateBucket(&s3.CreateBucketInput{
			Bucket:                     aws.String(bucketName),
			ObjectLockEnabledForBucket: aws.Bool(objectLocking),
		})
		if err != nil {
			log.Error(fmt.Sprintf(" '%s' bucket already exists", bucketName))
			continue
		}
	}

	return &provider{
		objectDb: s3client,
	}, nil
}
