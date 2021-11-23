provider "azurerm" {
    version = "2.85.0"
    features {}
}

resource "azurerm_resource_group" "driveShaftUsersMicroService" {
    name = "DriveShaftMicroServices"
    location = "Central US"
}

resource "azurerm_container_group" "dsUserMicroServContainer" {
    name = "usersserviceapi"
    location = azurerm_resource_group.driveShaftUsersMicroService.location
    resource_group_name = azurerm_resource_group.driveShaftUsersMicroService.name

    ip_address_type = "public"
    dns_name_label = "usersservicewebapi"
    os_type = "Linux"

    container {
        name = "usersserviceapi1"
        image = "fwafula/usersserviceapi"
        cpu = "1"
        memory = "2"

        ports {
            port = 80
            protocol = "TCP"
        }
    }
}