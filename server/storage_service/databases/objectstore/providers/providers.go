package providers

import (
	"context"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
)

type Provider interface {
	CreatePreassignedPutUrl(ctx context.Context, presignedPutUrl models.PresignedPutUrlInput) (*models.PresignedUrl, error)

	CreatePreassignedGetUrl(ctx context.Context, presignedGetUrl models.PresignedGetUrlInput) (*models.PresignedUrl, error)

	UploadObject(ctc context.Context, uploadObject models.UploadObjectInput) (*models.Object, error)

	RemoveObject(ctx context.Context, removeObject models.RemoveObjectInput) error

	GetBuckets(ctx context.Context) ([]*models.Bucket, error)

	CreateBucket(ctx context.Context, createBucket models.CreateBucketInput) (*models.Bucket, error)

	DeleteBucket(ctx context.Context, deleteBucket models.DeleteBucketInput) error
}
