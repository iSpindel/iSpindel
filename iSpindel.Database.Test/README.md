# Test with Mqtt

Install mosquitto cli-client:

```bash
sudo apt install mosquitto-clients
```

Send iSpindel Fake Data to mqtt broker from cli:

```bash
mosquitto_pub -h <IP> -u <user> -P <password> -t ispindel/iSpindel0/gravity -m "10"
mosquitto_pub -h <IP> -u <user> -P <password> -t ispindel/iSpindel0/temperature -m "25.005"
mosquitto_pub -h <IP> -u <user> -P <password> -t ispindel/iSpindel0/battery -m "4.0"`
```

Send Recording Request to broker from cli:

```bash
mosquitto_pub -h <IP> -u <user> -P <password> -t spindelControl/Request -m "Start|1"
mosquitto_pub -h <IP> -u <user> -P <password> -t spindelControl/Request -m "Stop"
mosquitto_pub -h <IP> -u <user> -P <password> -t spindelControl/Request -m "Status"
```

Test on Pi:

```bash
ssh bennyMpdPi
cd iSpindel
./iSpindel.Database.Job.Runner

pi@mqtt-pi:~ $ sudo tail -f /var/log/mosquitto/mosquitto.log
```

Manually listen on the topics

```bash
mosquitto_sub -h <IP> -u <user> -P <password> -t spindelControl/\# -v
mosquitto_sub -h <IP> -u <user> -P <password> -t ispindel/iSpindel0/\# -v
```

```bash
```
