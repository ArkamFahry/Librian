package resolvers

import (
	"context"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
	"github.com/ArkamFahry/trackx/server/storage_service/utils"
)

func DeleteBucketMutationResolver(ctx context.Context, params model.DeleteBucketInput) (*model.Response, error) {
	var err error
	var deleteBucket models.DeleteBucketInput

	if params.Name != "" {
		deleteBucket.Name = params.Name
	}

	buckets := memorystore.RequiredEnvStoreObj.GetRequiredEnv().BucketNames

	err = utils.CheckIfBucketExist(buckets, params.Name)
	if err != nil {
		return nil, err
	}

	err = objectstore.Provider.DeleteBucket(ctx, deleteBucket)
	if err != nil {
		return nil, err
	}

	return &model.Response{
		Message: "bucket successfully removed",
	}, nil
}
