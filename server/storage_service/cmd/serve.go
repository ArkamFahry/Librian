package cmd

import (
	"github.com/ArkamFahry/trackx/server/storage_service/databases/memorystore"
	"github.com/ArkamFahry/trackx/server/storage_service/handlers"
	"github.com/gin-gonic/gin"

	log "github.com/sirupsen/logrus"
)

func Serve() error {
	var err error
	mode := memorystore.RequiredEnvStoreObj.GetRequiredEnv().Mode

	gin.SetMode(mode)

	app := gin.New()

	app.POST("/graphql", handlers.GraphqlHandler())

	if mode != gin.ReleaseMode {
		app.GET("/", handlers.PlaygroundHandler())
	}

	port := memorystore.RequiredEnvStoreObj.GetRequiredEnv().Port

	err = app.Run(":" + port)
	if err != nil {
		log.Error("Error starting the server : ", err)
	}

	return err
}
