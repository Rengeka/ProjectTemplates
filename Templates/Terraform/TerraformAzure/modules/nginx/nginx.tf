data "azurerm_resource_group" "nginx_rg" {
  name = local.__RESOURCE__GROUP__NAME__
}

data "azurerm_container_app_environment" "container_env" {
  name                = local.__CONTAINER__ENV__NAME__
  resource_group_name = data.azurerm_resource_group.rankify_rg.name
}

resource "azurerm_container_app" "nginx" {
  name                          = local.__CONTAINER__APP__NAME__
  resource_group_name           = data.azurerm_resource_group.rankify_rg.name
  container_app_environment_id  = data.azurerm_container_app_environment.container_env.id
  revision_mode                 = var.nginx_revision_mode

  ingress {
    allow_insecure_connections = true  
    external_enabled           = true 
    target_port                = 80     

    traffic_weight {
      percentage       = 100 
      latest_revision  = true
    }
  }

  template {

    min_replicas = 1
    max_replicas = 2

    container {
      name   = local.__CONTAINER__NAME__
      image  = var.nginx_image
      cpu    = "0.5"
      memory = "1Gi" 
    }
  }
}