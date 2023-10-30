pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                // Restaura las dependencias y herramientas del proyecto
                bat 'dotnet restore'
            }
        }

        stage('Build') {
            steps {
                // Compila el proyecto y sus dependencias en un conjunto de archivos binarios
                bat 'dotnet build --configuration Release --no-restore'
            }
        }

        stage('Test') {
            steps {
                // Ejecuta las pruebas unitarias disponibles en el proyecto
                bat 'dotnet test --no-restore --verbosity normal'
            }
        }

        stage('Publish') {
            steps {
                // Publica la aplicación y sus dependencias en una carpeta para despliegue
                bat 'dotnet publish --configuration Release --no-build'
            }
        }
    }
}
