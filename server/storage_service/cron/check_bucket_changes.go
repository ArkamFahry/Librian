package cron

import (
	"context"

	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/databases/objectstore"
	"github.com/ArkamFahry/trackx/server/storage_service/utils"

	"github.com/jasonlvhit/gocron"
	log "github.com/sirupsen/logrus"
)

func CheckForBucketChanges() {
	ctx := context.Background()
	var returnedBuckets []string
	availableBuckets := memorystore.RequiredEnvStoreObj.GetRequiredEnv().BucketNames
	bucketsList, err := objectstore.Provider.GetBuckets(ctx)
	if err != nil {
		log.Error("Bucket Changes Check Cron Error : ", err)
	}

	for _, bucket := range bucketsList {
		returnedBuckets = append(returnedBuckets, bucket.Name)
	}

	diff := utils.DifferenceBetweenTwoStringSlices(returnedBuckets, availableBuckets)
	if diff != nil {
		requiredEnv := memorystore.RequiredEnvStoreObj.GetRequiredEnv()
		requiredEnv.BucketNames = returnedBuckets
		utils.RemoveDuplicateString(requiredEnv.BucketNames)
		memorystore.RequiredEnvStoreObj.SetRequiredEnv(requiredEnv)
	}
}

func CheckForBucketChangesJob() {
	cronTimer := memorystore.RequiredEnvStoreObj.GetRequiredEnv().CheckBucketChangesTimer
	cron := gocron.NewScheduler()

	cron.Every(cronTimer).Seconds().Do(CheckForBucketChanges)

	<-cron.Start()
}
