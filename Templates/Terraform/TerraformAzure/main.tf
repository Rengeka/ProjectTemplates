module "nginx" {
  source              = "./modules/nginx"
  nginx_revision_mode = var.nginx_revision_mode
  nginx_image         = var.nginx_image
}