package resolvers

import (
	"context"

	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
)

func CreateBucketMutationResolver(ctx context.Context, params model.CreateBucketInput) (*model.Bucket, error) {
	var createBucket models.CreateBucketInput

	if params.Name != "" {
		createBucket.Name = params.Name
	}

	createBucket.ObjectLocking = params.ObjectLocking

	res, err := objectstore.Provider.CreateBucket(ctx, createBucket)
	if err != nil {
		return nil, err
	}

	return &model.Bucket{
		Name:      res.Name,
		CreatedAt: res.CreatedAt,
	}, nil
}
