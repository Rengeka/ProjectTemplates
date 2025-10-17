resource "aws_security_group" "nginx_sg" {
  name        = local.__SECURITY__GROUP__NAME__

  ingress {
    from_port   = 22
    to_port     = 22
    protocol    = "tcp"
    cidr_blocks = ["0.0.0.0/0"]
  }

   ingress {
    from_port   = 80
    to_port     = 80
    protocol    = "tcp"
    cidr_blocks = ["0.0.0.0/0"]
  }

  egress {
    from_port   = 0
    to_port     = 65535
    protocol    = "tcp"
    cidr_blocks = ["0.0.0.0/0"]
  }
}

resource "aws_instance" "vm" {
  ami                    = var.ami
  instance_type          = var.instance_type
  vpc_security_group_ids = [aws_security_group.nginx_sg.id]

  user_data = <<-EOF
    #!/bin/bash
    yum update -y
    yum install -y docker

    systemctl enable docker
    systemctl start docker

    docker run -d --name nginx -p 8080:80 nginx:latest
  EOF

  tags = {
    Type = "VirtualMachine"
  }
}