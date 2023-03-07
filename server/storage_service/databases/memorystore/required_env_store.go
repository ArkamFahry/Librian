package memorystore

import (
	"errors"
	"sync"
	"time"

	"github.com/ArkamFahry/trackx/server/storage_service/constants"
	"github.com/ArkamFahry/trackx/server/storage_service/utils"

	log "github.com/sirupsen/logrus"
	"github.com/spf13/viper"
)

type RequiredEnv struct {
	Mode                    string        `json:"MODE"`
	Port                    string        `json:"PORT"`
	PublicUrl               string        `json:"PUBLIC_URL"`
	ObjectStoreType         string        `json:"OBJECT_STORE_TYPE"`
	ObjectStoreUrl          string        `json:"OBJECT_STORE_URL"`
	AccessKey               string        `json:"ACCESS_KEY"`
	SecretKey               string        `json:"SECRET_KEY"`
	UseSsl                  bool          `json:"USE_SSL"`
	BucketNames             []string      `json:"BUCKET_NAMES"`
	AwsRegion               string        `json:"AWS_REGION"`
	ObjectLocking           bool          `json:"OBJECT_LOCKING"`
	PresignedPutUrlExpiry   time.Duration `json:"PRESIGNED_PUT_URL_EXPIRY"`
	PresignedGetUrlExpiry   time.Duration `json:"PRESIGNED_GET_URL_EXPIRY"`
	CheckBucketChangesTimer uint64        `json:"CHECK_BUCKET_CHANGES_TIMER"`
}

type RequiredEnvStore struct {
	mutex       sync.Mutex
	requiredEnv RequiredEnv
}

func (r *RequiredEnvStore) GetRequiredEnv() RequiredEnv {
	r.mutex.Lock()
	defer r.mutex.Unlock()

	return r.requiredEnv
}

func (r *RequiredEnvStore) SetRequiredEnv(requiredEnv RequiredEnv) {
	r.mutex.Lock()
	defer r.mutex.Unlock()

	r.requiredEnv = requiredEnv
}

var RequiredEnvStoreObj *RequiredEnvStore

func InitRequiredEnv() error {

	viper.SetConfigFile(".env")

	err := viper.ReadInConfig()

	if err != nil {
		log.Error("couldn't load env from .env : ", err)
		viper.AutomaticEnv()
	}

	mode := viper.GetString(constants.EnvMode)
	port := viper.GetString(constants.EnvPort)
	publicUrl := viper.GetString(constants.EnvPublicUrl)
	objectStoreType := viper.GetString(constants.EnvObjectStoreType)
	objectStoreUrl := viper.GetString(constants.EnvObjectStoreUrl)
	accessKey := viper.GetString(constants.EnvAccessKey)
	secretKey := viper.GetString(constants.EnvSecretKey)
	useSsl := viper.GetBool(constants.EnvUseSsl)
	bucketNames := utils.StringToStringSlice(viper.GetString(constants.EnvBucketNames))
	awsRegion := viper.GetString(constants.EnvAwsRegion)
	objectLocking := viper.GetBool(constants.EnvObjectLocking)
	presignedPutUrlExpiry := viper.GetDuration(constants.EnvPresignedPutUrlExpiry)
	presignedGetUrlExpiry := viper.GetDuration(constants.EnvPresignedGetUrlExpiry)
	checkBucketChangesTimer := utils.DurationUint64(viper.GetDuration(constants.EnvCheckBucketChangesTimer))

	if mode == "" {
		mode = "release"
	}

	if port == "" {
		port = "8050"
	}

	if publicUrl == "" {
		return errors.New("object storage server public url required to start the server")
	}

	if objectStoreType == "" {
		objectStoreType = "minio"
	}

	if objectStoreUrl == "" {
		return errors.New("object storage server url required to start the server")
	}

	if accessKey == "" {
		return errors.New("object storage server access key is required to start the server")
	}

	if secretKey == "" {
		return errors.New("object storage server secret key is required to start the server")
	}

	if bucketNames == nil {
		bucketNames = append(bucketNames, "main")
	}

	if awsRegion == "" {
		awsRegion = "no-region"
	}

	if presignedPutUrlExpiry.Seconds() == 0 || presignedPutUrlExpiry.String() == "" {
		presignedPutUrlExpiry = time.Second * 30
	}

	if presignedGetUrlExpiry.Seconds() == 0 || presignedPutUrlExpiry.String() == "" {
		presignedGetUrlExpiry = time.Second * 600
	}

	if checkBucketChangesTimer == 0 {
		checkBucketChangesTimer = 10
	}

	requiredEnv := RequiredEnv{
		Mode:                    mode,
		Port:                    port,
		PublicUrl:               publicUrl,
		ObjectStoreType:         objectStoreType,
		ObjectStoreUrl:          objectStoreUrl,
		AccessKey:               accessKey,
		SecretKey:               secretKey,
		UseSsl:                  useSsl,
		BucketNames:             bucketNames,
		AwsRegion:               awsRegion,
		ObjectLocking:           objectLocking,
		PresignedPutUrlExpiry:   presignedPutUrlExpiry,
		PresignedGetUrlExpiry:   presignedGetUrlExpiry,
		CheckBucketChangesTimer: checkBucketChangesTimer,
	}

	RequiredEnvStoreObj = &RequiredEnvStore{
		requiredEnv: requiredEnv,
	}

	return nil
}
