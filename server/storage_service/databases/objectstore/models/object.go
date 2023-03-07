package models

import "github.com/99designs/gqlgen/graphql"

type Object struct {
	Name   string `json:"name"`
	Path   string `json:"path"`
	Bucket string `json:"bucket"`
}

type UploadObjectInput struct {
	Name       string         `json:"name"`
	BucketName string         `json:"bucket_name"`
	Object     graphql.Upload `json:"object"`
}

type RemoveObjectInput struct {
	Name       string `json:"name"`
	BucketName string `json:"bucket_name"`
}
