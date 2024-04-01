## Docker Commands

### Docker Build

```bash
docker build -t thutasann/platformservice .
```

```bash
docker build -t thutasann/commandservice .
```

### Docker Push

```bash
docker push thutasann/platformservice
```

```bash
docker push thutasann/commandservice
```

## Kubernetes Commands

### Check version

```bash
kubectl version
```

### Create Deployment

```bash
cd K8S

kubectl apply -f platforms-depl.yaml
```

### Get Deployments

```bash
kubectl get deployments
```

### Refresh Deployments

```bash
kubectl rollout restart deployment platforms-depl
```

### Get Services

```bash
kubectl get services
```

### Get pods

```bash
kubectl get pods
```

### Get namespace

```bash
kubectl get namespace
```

### Get Storage Class

```bash
kubectl get storageclass
```

### Delete Deployment / Service

```bash
kubectl delete deployment <deployment-name>
```

```bash
kubectl delete service <service-name>
```

### Ingress Controller NGINX Installation

```bash
kubectl apply -f https://raw.githubusercontent.com/kubernetes/ingress-nginx/controller-v1.10.0/deploy/static/provider/cloud/deploy.yaml
```

```bash
kubectl get pods --namespace=ingress-nginx
```

### K&S Secret

**MSSQL**

```bash
kubectl create secret generic mssql --from-literal=SA_PASSWORD="thutasann2002@TTS!"
```

```json
{
    "username": "SA",
    "password": "thutasann2002@TTS!"
}
```

**MYSQL**

```bash
kubectl create secret generic mysql-secret \
  --from-literal=MYSQL_ROOT_PASSWORD=thutasann2002@TTS! \
  --from-literal=MYSQL_USER=thuta \
  --from-literal=MYSQL_PASSWORD=thutasann2002tts \
  --from-literal=MYSQL_DATABASE=test_db
```

```json
{
    "username": "thuta",
    "password": "thutasann2002tts"
}
```

### Delete Secret

```bash
kubectl delete secret mssql
```

### Port Forwarding

```bash
kubectl port-forward deployment/mssql-depl 1431:1431
```
