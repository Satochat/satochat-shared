#!/bin/sh

if [ ! -z "$STRONG_NAME_KEY" ]; then
    echo $STRONG_NAME_KEY | base64 -d > ./secrets/StrongNameKey.snk || exit 1
fi
