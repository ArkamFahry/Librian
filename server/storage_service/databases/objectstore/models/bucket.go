package models

type Bucket struct {
	Name      string `json:"name"`
	CreatedAt int64  `json:"created_at"`
}

type CreateBucketInput struct {
	Name          string `json:"name"`
	ObjectLocking bool   `json:"object_locking"`
}

type DeleteBucketInput struct {
	Name string `json:"name"`
}
