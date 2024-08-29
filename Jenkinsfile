pipeline {
    agent any

    environment {
        DOTNET_CLI_HOME = "C:\\Program Files\\dotnet"
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }

        stage('Build') {
            steps {
                script {
                    // Restoring dependencies
                    bat "${env.DOTNET_CLI_HOME}\\dotnet restore"

                    // Building the application
                    bat "${env.DOTNET_CLI_HOME}\\dotnet build --configuration Release"
                }
            }
        }

        stage('Test') {
            steps {
                script {
                    // Running tests
                    bat "${env.DOTNET_CLI_HOME}\\dotnet test --no-restore --configuration Release"
                }
            }
        }

        stage('Publish') {
            steps {
                script {
                    // Publishing the application
                    bat "${env.DOTNET_CLI_HOME}\\dotnet publish --no-restore --configuration Release --output .\\publish"
                }
            }
        }
    }

    post {
        success {
            echo 'Build, test, and publish successful!'
        }
        failure {
            echo 'Build, test, or publish failed.'
        }
    }
}
