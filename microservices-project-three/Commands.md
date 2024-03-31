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

### Delete Deployment / Service

```bash
kubectl delete deployment <deployment-name>
```

```bash
kubectl delete service <service-name>
```
