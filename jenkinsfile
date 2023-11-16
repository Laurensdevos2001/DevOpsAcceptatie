pipeline {
    agent any

    stages {
        stage('Delete REPO') {
            steps {
                sh 'if [ -d Oogarts ]; then rm -rf Oogarts; fi'
                sh 'if [ -d oogarts ]; then rm -rf oogarts; fi'
            }
        }        

        stage('Git Checkout') {
            steps {
                script {
                    git branch: 'development', credentialsId: 'testID', url: 'git@github.com:HOGENTDevOpsPrj/devops-23-24-net-g06.git'
                }
            }
        }

      
        stage('Modify appsettings.json') {
            steps {
                script {
                    sh '''sed -i 's|"Microsoft.AspNetCore": "Warning"| "Microsoft.Hosting.Lifetime": "Information",\\n    "ConnectionStrings": {\\n      "SqlDatabase": "Server=sql-server-container;Database=SportStore;User Id=SA;Password=AVeryComplex123Password;MultipleActiveResultSets=true"\\n    }|' oogarts/Server/appsettings.json'''
                }
            }
        }


        stage('Install Tailwind CSS') {
            steps {
                script {
                    sh 'cd oogarts/Client && npm install tailwindcss'
                }
            }
        }
        
        stage('Rename Project Files') {
            steps {
                script {
                    sh 'mv oogarts/Server/oogarts.Server.csproj oogarts/Server/Oogarts.Server.csproj'
                    sh 'mv oogarts/Shared/oogarts.Shared.csproj oogarts/Shared/Oogarts.Shared.csproj'
                    sh 'mv oogarts/Client/oogarts.Client.csproj oogarts/Client/Oogarts.Client.csproj'
                }
            }
        }
        

        stage('Copy files to dotnet6-container') {
            steps {
                script {
                    sh 'docker cp /var/jenkins_home/workspace/Testing/Oogarts dotnet6-container:'
                    sh 'docker cp /var/jenkins_home/workspace/Testing/oogarts dotnet6-container:'
                }
            }
        }

        stage('Build and Test in dotnet6-container') {
            steps {
                script {
                    sh 'docker exec dotnet6-container dotnet restore Server/oogarts.Server.csproj'
                    sh 'docker exec dotnet6-container dotnet dotnet build Server/oogarts.Server.csproj'
                }
            }
        }
    }
}
