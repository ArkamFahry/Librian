package resolvers

import (
	"context"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
)

func MetaDataQueryResolver(ctx context.Context) (*model.MetaData, error) {
	availableBuckets := memorystore.RequiredEnvStoreObj.GetRequiredEnv().BucketNames

	return &model.MetaData{
		AvailableBuckets: availableBuckets,
	}, nil
}
