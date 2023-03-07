package graph

// This file will be automatically regenerated based on the schema, any resolver implementations
// will be copied through when generating and any unknown code will be moved to the end.
// Code generated by github.com/99designs/gqlgen version v0.17.24

import (
	"context"

	"github.com/ArkamFahry/trackx/server/storage_service/graph/model"
	"github.com/ArkamFahry/trackx/server/storage_service/resolvers"
)

// UploadObject is the resolver for the upload_object field.
func (r *mutationResolver) UploadObject(ctx context.Context, params model.UploadObjectInput) (*model.Object, error) {
	return resolvers.UploadObjectMutationResolver(ctx, params)
}

// RemoveObject is the resolver for the remove_object field.
func (r *mutationResolver) RemoveObject(ctx context.Context, params model.RemoveObjectInput) (*model.Response, error) {
	return resolvers.RemoveObjectMutationResolver(ctx, params)
}

// CreateBucket is the resolver for the _create_bucket field.
func (r *mutationResolver) CreateBucket(ctx context.Context, params model.CreateBucketInput) (*model.Bucket, error) {
	return resolvers.CreateBucketMutationResolver(ctx, params)
}

// DeleteBucket is the resolver for the _delete_bucket field.
func (r *mutationResolver) DeleteBucket(ctx context.Context, params model.DeleteBucketInput) (*model.Response, error) {
	return resolvers.DeleteBucketMutationResolver(ctx, params)
}

// PresignedPutURL is the resolver for the presigned_put_url field.
func (r *queryResolver) PresignedPutURL(ctx context.Context, params model.PresignedPutURLInput) (*model.PresignedURL, error) {
	return resolvers.PresignedPutUrlQueryResolver(ctx, params)
}

// PresignedGetURL is the resolver for the presigned_get_url field.
func (r *queryResolver) PresignedGetURL(ctx context.Context, params model.PresignedGetURLInput) (*model.PresignedURL, error) {
	return resolvers.PresignedGetUrlQueryResolver(ctx, params)
}

// MetaData is the resolver for the _meta_data field.
func (r *queryResolver) MetaData(ctx context.Context) (*model.MetaData, error) {
	return resolvers.MetaDataQueryResolver(ctx)
}

// AvailableBuckets is the resolver for the available_buckets field.
func (r *queryResolver) AvailableBuckets(ctx context.Context) ([]*model.Bucket, error) {
	return resolvers.AvailableBucketsQueryResolver(ctx)
}

// Mutation returns MutationResolver implementation.
func (r *Resolver) Mutation() MutationResolver { return &mutationResolver{r} }

// Query returns QueryResolver implementation.
func (r *Resolver) Query() QueryResolver { return &queryResolver{r} }

type mutationResolver struct{ *Resolver }
type queryResolver struct{ *Resolver }
