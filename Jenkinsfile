pipeline
{
	agent any
	
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
		        bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Professional\\MSBuild\\15.0\\Bin\\MSBuild.exe" d:\\JenkinsLearnSampleApp\\UnderstandingJenkins-TestingPurpose\\WebApplication\\WebApplication.sln /t:Clean;Build /p:Configuration=Release /p:TargetFramework=v4.6.1  /p:SkipPostSharp=True /p:RunCodeAnalysis=False /p:VisualStudioVersion=15.0'
		    }
		
		}
		stage('publish')
		{
		    steps
		    {
		        bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Professional\\MSBuild\\15.0\\Bin\\MSBuild.exe" C:\\Users\\Achyut\\source\\repos\\MVCUnitTestingDemo\\MVCUnitTestingDemo\\MVCUnitTestingDemo.csproj /t:Build /p:DeployOnBuild=true /p:PublishProfile=CustomProfile /p:Configuration=Release /p:TargetFramework=v4.6.1 /p:VisualStudioVersion=15.0 /p:RestorePackages=false /p:SkipPostSharp=true'
		    }
		
		}
		stage('test')
		{
		    steps
		    {				
		        bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Professional\\Common7\\IDE\\Extensions\\TestPlatform\\vstest.console.exe" C:\\Users\\Achyut\\source\\repos\\MVCUnitTestingDemo\\MVCUnitTestingDemo.Tests\\bin\\Debug\\MVCUnitTestingDemo.Tests.dll'
		    }
		
		}
	}
}