package resolvers

import (
	"context"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"
	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
)

func AvailableBucketsQueryResolver(ctx context.Context) ([]*model.Bucket, error) {
	var availableBuckets []*model.Bucket

	buckets, err := objectstore.Provider.GetBuckets(ctx)
	if err != nil {
		return nil, err
	}

	for _, bucket := range buckets {
		availableBuckets = append(availableBuckets, &model.Bucket{
			Name:      bucket.Name,
			CreatedAt: bucket.CreatedAt,
		})
	}

	return availableBuckets, nil
}
