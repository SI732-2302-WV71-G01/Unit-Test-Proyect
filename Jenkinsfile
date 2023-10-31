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

        stage('Build') {
            steps {
                // Cambia al directorio que contiene el archivo de proyecto o solución
                dir('Backend-main/PcBuilders.API') {
                    // Compila el proyecto y sus dependencias en un conjunto de archivos binarios
                    bat 'dotnet restore'
                }
            }
        }

        stage('Test') {
            steps {
                // Ejecuta Unit Test
                dir('Backend-main/PcBuilders.API/TestProject1') {
                          bat 'dotnet test'


                }
                
            }
        }



   

    }
}
