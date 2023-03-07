#build stage
FROM golang:alpine AS builder
RUN apk add --no-cache git
WORKDIR /go/src/app
COPY . .
RUN go get -d -v 
RUN go build -o /app -v 

#final stage
FROM alpine:latest
RUN apk --no-cache add ca-certificates
COPY --from=builder /app /app
ENTRYPOINT /app
LABEL Name=storageservice Version=0.0.1
EXPOSE 8050
CMD [ "./app/main" ]