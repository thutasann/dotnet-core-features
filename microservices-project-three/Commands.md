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

**MYSQL (Just a Testing)**

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
kubectl port-forward service/mssql-loadbalancer 1433:1433
```

### Get External IP of the LoadBalancer

```bash
kubectl get svc mssqlnpservice-srv
```

### Check K8S Secret

```bash
kubectl get secret mssql -o jsonpath="{.data.SA_PASSWORD}" | base64 --decode
```

### Validate pod and check the printenv

```bash
kubectl exec -it mysql-deployment-868b8fb8d8-xm8fx -- /bin/bash
```

```bash
printenv
```

### K8S describe

```bash
kubectl describe service mysql-loadbalancer
```
