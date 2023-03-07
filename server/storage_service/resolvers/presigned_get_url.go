package resolvers

import (
	"context"

	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/models"
	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
	"github.com/ArkamFahry/trackx/server/storage_service/utils"
)

func PresignedGetUrlQueryResolver(ctx context.Context, params model.PresignedGetURLInput) (*model.PresignedURL, error) {
	var err error
	var presignedGetUrl models.PresignedGetUrlInput

	if params.ObjectName != "" {
		presignedGetUrl.ObjectName = params.ObjectName
	}

	if params.BucketName != "" {
		presignedGetUrl.BucketName = params.BucketName
	}

	buckets := memorystore.RequiredEnvStoreObj.GetRequiredEnv().BucketNames

	err = utils.CheckIfBucketExist(buckets, presignedGetUrl.BucketName)
	if err != nil {
		return nil, err
	}

	res, err := objectstore.Provider.CreatePreassignedGetUrl(ctx, presignedGetUrl)
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
