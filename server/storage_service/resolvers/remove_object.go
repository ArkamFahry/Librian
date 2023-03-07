package resolvers

import (
	"context"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
	"github.com/ArkamFahry/trackx/server/storage_service/utils"
)

func RemoveObjectMutationResolver(ctx context.Context, params model.RemoveObjectInput) (*model.Response, error) {
	var err error
	var removeObject models.RemoveObjectInput

	if params.BucketName != "" {
		removeObject.BucketName = params.BucketName
	}

	buckets := memorystore.RequiredEnvStoreObj.GetRequiredEnv().BucketNames

	err = utils.CheckIfBucketExist(buckets, removeObject.BucketName)
	if err != nil {
		return nil, err
	}

	err = objectstore.Provider.RemoveObject(ctx, models.RemoveObjectInput{
		Name:       params.Name,
		BucketName: params.BucketName,
	})
	if err != nil {
		return nil, err
	}

	return &model.Response{
		Message: "object successfully removed",
	}, nil
}
