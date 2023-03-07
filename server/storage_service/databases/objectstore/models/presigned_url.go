package models

type PresignedUrl struct {
	ObjectName   string `json:"object_name"`
	Url          string `json:"url"`
	UrlOperation string `json:"url_operation"`
	Bucket       string `json:"bucket"`
	Path         string `json:"path"`
	Expiry       string `json:"expiry"`
}

type PresignedPutUrlInput struct {
	ObjectName string `json:"object_name"`
	BucketName string `json:"bucket_name"`
}

type PresignedGetUrlInput struct {
	ObjectName string `json:"object_name"`
	BucketName string `json:"bucket_name"`
}
