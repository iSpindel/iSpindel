#!/bin/bash
PUB_INTERVAL=3000
BAT_TOPIC=ispindel/iSpindel0/battery
BAT_MEAN=50
GRAV_TOPIC=ispindel/iSpindel0/gravity
GRAV_MEAN=10
TEMP_TOPIC=ispindel/iSpindel0/temperature
TEMP_MEAN=20


if [ $( docker inspect mqtt-producer --format {{.State.Status}} ) != "running" ]; then
  echo "Container mqtt-producer does not exist or is not running."
  echo "Are you missing a docker start mqtt-producer ?"
  exit;
fi

echo "Removing existing workers"
curl --request PATCH localhost:8080/workers/stop
curl --request PATCH localhost:8080/workers/delete

echo "Creating Payload for Battery:"
echo "Topic: $BAT_TOPIC, Mean: $BAT_MEAN"
curl -X POST -H "Content-Type: application/json" -d '{ "SubscriptionTopic": "stest", "PayloadOptions": { "PayloadType" : "NormalDistribution", "PublishTopic" : "'$BAT_TOPIC'", "Mean" : '$BAT_MEAN', "Stddev" : 1 }, "ShapeOptions": { "ShapeType" : "Interval", "LengthInMs" : '$PUB_INTERVAL' }}' localhost:8080/workers/new
echo ""

echo "Creating Payload for Gravity:"
echo "Topic: $GRAV_TOPIC, Mean: $GRAV_MEAN"
curl -X POST -H "Content-Type: application/json" -d '{ "SubscriptionTopic": "stest", "PayloadOptions": { "PayloadType" : "NormalDistribution", "PublishTopic" : "'$GRAV_TOPIC'", "Mean" : '$GRAV_MEAN', "Stddev" : 1 }, "ShapeOptions": { "ShapeType" : "Interval", "LengthInMs" : '$PUB_INTERVAL' }}' localhost:8080/workers/new
echo ""

echo "Creating Payload for Temperature:"
echo "Topic: $TEMP_TOPIC, Mean: $TEMP_MEAN"
curl -X POST -H "Content-Type: application/json" -d '{ "SubscriptionTopic": "stest", "PayloadOptions": { "PayloadType" : "NormalDistribution", "PublishTopic" : "'$TEMP_TOPIC'", "Mean" : '$TEMP_MEAN', "Stddev" : 1 }, "ShapeOptions": { "ShapeType" : "Interval", "LengthInMs" : '$PUB_INTERVAL' }}' localhost:8080/workers/new
echo ""

echo "Starting all workers"
curl --request PATCH localhost:8080/workers/start