package cmd

import (
	"github.com/ArkamFahry/trackx/server/storage_service/cron"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"

	log "github.com/sirupsen/logrus"
)

func BootStrap() error {
	var err error

	err = memorystore.InitRequiredEnv()
	if err != nil {
		log.Fatal("Error initializing required env : ", err)
	}

	err = objectstore.InitObjectStore()
	if err != nil {
		log.Fatal("Error initializing object store : ", err)
	}

	go func() {
		cron.InitCronJobs()
	}()

	return err
}
