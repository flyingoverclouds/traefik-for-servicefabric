# sftcl
see https://docs.microsoft.com/en-us/azure/service-fabric/service-fabric-sfctl


## connection to a cluster

### localdev cluster
sfctl cluster select --endpoint http://localhost:19080

## uppgrade an existing app to a new version
sfctl application upgrade --application-name "fabric:/8bits" --application-version "1.0.1"  --parameters '{}'

## list all property
sfctl property list --name "8bits/cpc464"


## get a property
sfctl property get  --name "8bits/cpc464" --property-name "traefik.expose"