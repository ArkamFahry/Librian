package minio

import (
	"context"

	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/aws/aws-sdk-go/service/s3"
)

func (p *provider) UploadObject(ctx context.Context, uploadObject models.UploadObjectInput) (*models.Object, error) {
	_, err := p.objectDb.PutObject(&s3.PutObjectInput{
		Bucket:        &uploadObject.BucketName,
		Key:           &uploadObject.Name,
		Body:          uploadObject.Object.File,
		ContentType:   &uploadObject.Object.ContentType,
		ContentLength: &uploadObject.Object.Size,
	})
	if err != nil {
		return nil, err
	}

	return &models.Object{
		Name:   uploadObject.Name,
		Path:   uploadObject.BucketName + "/" + uploadObject.Name,
		Bucket: uploadObject.BucketName,
	}, nil
}

func (p *provider) RemoveObject(ctx context.Context, removeObject models.RemoveObjectInput) error {
	_, err := p.objectDb.DeleteObject(&s3.DeleteObjectInput{
		Bucket: &removeObject.BucketName,
		Key:    &removeObject.Name,
	})
	if err != nil {
		return err
	}

	return nil
}
