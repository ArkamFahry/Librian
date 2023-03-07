package resolvers

import (
	"context"

	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
	"github.com/ArkamFahry/trackx/server/storage_service/utils"
)

func PresignedPutUrlQueryResolver(ctx context.Context, params model.PresignedPutURLInput) (*model.PresignedURL, error) {
	var err error
	var presignedPutUrl models.PresignedPutUrlInput

	if params.ObjectName != "" {
		presignedPutUrl.ObjectName = params.ObjectName
	}

	if params.BucketName != "" {
		presignedPutUrl.BucketName = params.BucketName
	}

	buckets := memorystore.RequiredEnvStoreObj.GetRequiredEnv().BucketNames

	err = utils.CheckIfBucketExist(buckets, presignedPutUrl.BucketName)
	if err != nil {
		return nil, err
	}

	res, err := objectstore.Provider.CreatePreassignedPutUrl(ctx, presignedPutUrl)
	if err != nil {
		return nil, err
	}

	return &model.PresignedURL{
		ObjectName:   res.ObjectName,
		URL:          res.Url,
		URLOperation: res.UrlOperation,
		Bucket:       res.Bucket,
		Path:         res.Path,
		Expiry:       res.Expiry,
	}, nil
}
