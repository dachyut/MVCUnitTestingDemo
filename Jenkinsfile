pipeline
{
	agent 
	{
        label "Agent1"
    }
	
	tools
	{
        msbuild 'msbuild'
    }
	
    stages {
		stage('Checkout')
		{
			steps {
				git credentialsId: 'c92bb9fa-189d-49b8-a07b-21f15f885ce7', url: 'https://github.com/dachyut/MVCUnitTestingDemo.git'

			}
		}
		
		stage('build')
		{
		    steps
		    {
		        bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Professional\\MSBuild\\15.0\\Bin\\MSBuild.exe" MVCUnitTestingDemo.sln /t:Clean;Build /p:Configuration=Release /p:TargetFramework=v4.6.1  /p:SkipPostSharp=True /p:RunCodeAnalysis=False /p:VisualStudioVersion=15.0'
		    }
		
		}
		stage('publish')
		{
		    steps
		    {
		        bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Professional\\MSBuild\\15.0\\Bin\\MSBuild.exe" MVCUnitTestingDemo\\MVCUnitTestingDemo.csproj /t:Build /p:DeployOnBuild=true /p:PublishProfile=CustomProfile /p:Configuration=Release /p:TargetFramework=v4.6.1 /p:VisualStudioVersion=15.0 /p:RestorePackages=false /p:SkipPostSharp=true'
		    }
		
		}
		stage('test')
		{
			parallel {
				stage('Test On Agent1') {
                    agent {
                        label "Agent1"
                    }
                    steps {
						echo "Started on Agent1"
						bat 'notepad.exe'
                        bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Professional\\Common7\\IDE\\Extensions\\TestPlatform\\vstest.console.exe" MVCUnitTestingDemo.Tests\\bin\\Debug\\MVCUnitTestingDemo.Tests.dll'
                    }
				}	
				stage('Test On Agent2') {
                    agent {
                        label "Windows7"
                    }
                    steps {
						echo "Started on Agent2"
						bat 'notepad.exe'
                        bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Professional\\Common7\\IDE\\Extensions\\TestPlatform\\vstest.console.exe" MVCUnitTestingDemo.Tests\\bin\\Debug\\MVCUnitTestingDemo.Tests.dll'
                    }
				}
			}
			
		    
		}
	}
}