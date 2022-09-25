payload for mqtt-producer:
curl -X POST -H "Content-Type: application/json" -d '{ "SubscriptionTopic": "stest", "PayloadOptions": { "PayloadType" : "NormalDistribution", "PublishTopic" : "ispindel/iSpindel0/battery", "Mean" : 50, "Stddev" : 1 }, "ShapeOptions": { "ShapeType" : "Interval", "LengthInMs" : 3000 }}' localhost:8080/workers/new

 curl -X POST -H "Content-Type: application/json" -d '{ "SubscriptionTopic": "stest", "PayloadOptions": { "PayloadType" : "NormalDistribution", "PublishTopic" : "ispindel/iSpindel0/gravity", "Mean" : 10, "Stddev" : 1 }, "ShapeOptions": { "ShapeType" : "Interval", "LengthInMs" : 3000 }}' localhost:8080/workers/new

 curl -X POST -H "Content-Type: application/json" -d '{ "SubscriptionTopic": "stest", "PayloadOptions": { "PayloadType" : "NormalDistribution", "PublishTopic" : "ispindel/iSpindel0/gravity", "Mean" : 20, "Stddev" : 1 }, "ShapeOptions": { "ShapeType" : "Interval", "LengthInMs" : 3000 }}' localhost:8080/workers/new

Start all workers:
curl --request PATCH localhost:8080/workers/start

or use the generate-payload.sh script

watch with:
mosquitto_sub -h localhost -t ispindel/iSpindel0/battery
mosquitto_sub -h localhost -t ispindel/iSpindel0/gravity
mosquitto_sub -h localhost -t ispindel/iSpindel0/temperature