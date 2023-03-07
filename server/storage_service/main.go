package main

import (
	"github.com/ArkamFahry/trackx/server/storage_service/cmd"

	log "github.com/sirupsen/logrus"
)

func main() {
	var err error

	log.SetFormatter(&log.JSONFormatter{})

	err = cmd.BootStrap()
	if err != nil {
		log.Fatal("Error bootstrapping server : ", err)
	}

	err = cmd.Serve()
	if err != nil {
		log.Fatal("Error starting server : ", err)
	}
}
