#!/bin/bash

if [ ! -d /opt/ispindel ]; then
    mkdir -p /opt/ispindel/mosquitto/config
    mkdir -p /opt/ispindel/mosquitto/logs
    mkdir -p /opt/ispindel/mosquitto/data
    mkdir -p /opt/ispindel/postgres
    chown -R pi:pi /opt/ispindel
fi

if [[ -f ~/iSpindel/mosquitto.conf && ! -f /opt/ispindel/config/mosquitto.conf ]]; then
    cp ~/iSpindel/mosquitto.conf /opt/ispindel/config/mosquitto.conf
fi

