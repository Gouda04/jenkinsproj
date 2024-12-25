pipeline {
    agent any
    stages {
        stage('Build') {
            steps {

                bat 'dotnet build ./GrpcService/GrpcService.sln'
            }
        }
        stage('Test') {
            steps {
                // Specify each solution or test project file explicitly

                bat 'dotnet test ./GrpcService/GrpcService.sln'
            }
        }
        stage('Docker Build') {
            steps {
                bat 'docker-compose build'
            }
        }
        stage('Deploy') {
            steps {
                bat 'docker-compose up -d'
            }
        }
    }
}
