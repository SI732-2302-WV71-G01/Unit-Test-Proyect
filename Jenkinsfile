pipeline {
    agent any

    stages {
        stage('Restore') {
            steps {
                // Cambia al directorio que contiene el archivo de proyecto o solución
                dir('Backend-main/PcBuilders.API') {
                    // Restaura las dependencias y herramientas del proyecto
                    bat 'dotnet restore'
                }
            }
        }

        /*stage('Build') {
            steps {
                // Cambia al directorio que contiene el archivo de proyecto o solución
                dir('Backend-main/PcBuilders.API') {
                    // Compila el proyecto y sus dependencias en un conjunto de archivos binarios
                    bat 'dotnet build --configuration Release --no-restore'
                }
            }
        }*/

        stage('Test') {
            steps {
                // Cambia al directorio que contiene el archivo de proyecto o solución
                dir('Backend-main/PcBuilders.API') {
                    // Ejecuta las pruebas unitarias disponibles en el proyecto
                    bat 'dotnet test --no-restore --verbosity normal'
                }
            }
        }

        stage('Publish') {
            steps {
                // Cambia al directorio que contiene el archivo de proyecto o solución
                dir('Backend-main/PcBuilders.API') {
                    // Publica la aplicación y sus dependencias en una carpeta para despliegue
                    bat 'dotnet publish --configuration Release --no-build'
                }
            }
        }
    }
}
