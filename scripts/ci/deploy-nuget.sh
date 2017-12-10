#!/bin/sh

versionSuffix=$1

dotnet pack --configuration Release --include-symbols --include-source --version-suffix "$versionSuffix" || exit 1
ls */bin/Release/*.nupkg | grep -v '\.symbols\.nupkg$' | while read path; do
    dotnet nuget push --source "$DEPLOY_URL" --symbol-source "$DEPLOY_SYMBOLS_URL" --api-key "$DEPLOY_API_KEY" --symbol-api-key "$DEPLOY_API_KEY" "$path" || exit 1
done
