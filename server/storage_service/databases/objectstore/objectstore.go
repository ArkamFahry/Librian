package objectstore

import (
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/providers"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore/providers/minio"

	log "github.com/sirupsen/logrus"
)

var Provider providers.Provider

func InitObjectStore() error {
	var err error

	Provider, err = minio.NewProvider()
	if err != nil {
		log.Fatal("Failed to initialize object store : ", err)
		return err
	}

	return nil
}
