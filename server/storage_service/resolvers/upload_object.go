package resolvers

import (
	"context"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
	"github.com/ArkamFahry/trackx/server/storage_service/utils"
)

func UploadObjectMutationResolver(ctx context.Context, params model.UploadObjectInput) (*model.Object, error) {
	var err error
	var uploadObject models.UploadObjectInput

	if params.Name != "" {
		uploadObject.Name = params.Name
	}

	if params.BucketName != "" {
		uploadObject.BucketName = params.BucketName
	}

	buckets := memorystore.RequiredEnvStoreObj.GetRequiredEnv().BucketNames

	err = utils.CheckIfBucketExist(buckets, uploadObject.BucketName)
	if err != nil {
		return nil, err
	}

	uploadObject.Object = params.Object

	res, err := objectstore.Provider.UploadObject(ctx, uploadObject)
	if err != nil {
		return nil, err
	}

	return &model.Object{
		Name:   res.Name,
		Bucket: res.Bucket,
		Path:   res.Path,
	}, nil
}
