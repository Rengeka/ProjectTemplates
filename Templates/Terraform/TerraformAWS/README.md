# AWS Terraform 

A simple terraform project template for configuring AWS Cloud infrastructure 

## 🛠️ Getting Started

### Prerequisites

- [Terraform v1.3.0+](https://developer.hashicorp.com/terraform/install)
- [Access to AWS Cloud Console](https://aws.amazon.com/) 
- [AWS CLI with configured credentials](https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-getting-started.html)
- Optional: VS Code with Hashicorp Terraform extention

### Build & Run

Clone the repository and navigate to the template directory

Choose a variable format to use (Delete either .tfvars.json or .tfvars)

Initialize Terraform:

```bash
terraform init
```

Preview the deployment plan:

```bash
terraform plan
```

Apply the configuration:

```bash
terraform apply
```