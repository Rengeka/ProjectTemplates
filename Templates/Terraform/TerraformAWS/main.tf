module "nginx" {
  source        = "./modules/nginx"
  instance_type = var.nginx_instance_type
  ami           = var.nginx_ami
}