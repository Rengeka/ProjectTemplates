variable "region" {
  description = "AWS region"
  type        = string
}

variable "environment" {
  description = "Project environment"
  type        = string
}

variable "nginx_instance_type" {
  description = "EC2 instance type"
  type        = string
}

variable "nginx_ami" {
  description = "AMI ID for EC2"
  type        = string
}