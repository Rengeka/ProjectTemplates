# Azure Terraform 

A simple terraform project template for configuring Azure infrastructure 

## 🛠️ Getting Started

### Prerequisites

- [Terraform v1.3.0+](https://developer.hashicorp.com/terraform/install)
- [Access to Azure Portal](https://azure.microsoft.com/en-us/get-started/azure-portal) 
- Optional: VS Code with Hashicorp Terraform extention

### Build & Run

Clone the repository and navigate to the template directory

Choose a variable format to use (Delete either .tfvars.json or .tfvars)

Initialize Terraform:

```bash
terraform init
```

Preview the deployment plan (You will need to enter subscription id):

```bash
terraform plan
```

Apply the configuration (You will need to enter subscription id):

```bash
terraform apply
```