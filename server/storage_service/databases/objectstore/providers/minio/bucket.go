package minio

import (
	"context"
	"time"

	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/ArkamFahry/trackx/server/storage_service/utils"
	"github.com/aws/aws-sdk-go/service/s3"
)

func (p *provider) GetBuckets(ctx context.Context) ([]*models.Bucket, error) {
	var bucketList []*models.Bucket

	buckets, err := p.objectDb.ListBuckets(&s3.ListBucketsInput{})
	if err != nil {
		return nil, err
	}

	for _, bucket := range buckets.Buckets {
		bucketList = append(bucketList, &models.Bucket{
			Name:      *bucket.Name,
			CreatedAt: bucket.CreationDate.Unix(),
		})
	}

	return bucketList, nil
}

func (p *provider) CreateBucket(ctx context.Context, createBucket models.CreateBucketInput) (*models.Bucket, error) {
	_, err := p.objectDb.CreateBucket(&s3.CreateBucketInput{
		Bucket:                     &createBucket.Name,
		ObjectLockEnabledForBucket: &createBucket.ObjectLocking,
	})
	if err != nil {
		return nil, err
	}

	requiredEnv := memorystore.RequiredEnvStoreObj.GetRequiredEnv()
	requiredEnv.BucketNames = append(requiredEnv.BucketNames, createBucket.Name)
	memorystore.RequiredEnvStoreObj.SetRequiredEnv(requiredEnv)

	return &models.Bucket{
		Name:      createBucket.Name,
		CreatedAt: time.Now().Unix(),
	}, nil
}

func (p *provider) DeleteBucket(ctx context.Context, deleteBucket models.DeleteBucketInput) error {
	_, err := p.objectDb.DeleteBucket(&s3.DeleteBucketInput{
		Bucket: &deleteBucket.Name,
	})
	if err != nil {
		return err
	}

	requiredEnv := memorystore.RequiredEnvStoreObj.GetRequiredEnv()
	requiredEnv.BucketNames = utils.RemoveElementInSliceByValue(requiredEnv.BucketNames, deleteBucket.Name)
	memorystore.RequiredEnvStoreObj.SetRequiredEnv(requiredEnv)

	return nil
}
