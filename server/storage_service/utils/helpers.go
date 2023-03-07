package utils

import (
	"errors"
)

func CheckIfBucketExist(buckets []string, bucket string) error {
	if !StringSliceContains(buckets, bucket) {
		return errors.New("bucket doesn't exist in available buckets")
	}

	return nil
}
