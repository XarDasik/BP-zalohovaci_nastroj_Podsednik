<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="15.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
  <Import Project="$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props" Condition="Exists('$(MSBuildExtensionsPath)\$(MSBuildToolsVersion)\Microsoft.Common.props')" />
  <PropertyGroup>
    <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
    <Platform Condition=" '$(Platform)' == '' ">AnyCPU</Platform>
    <ProjectGuid>{BEEE88C7-26FB-405C-B728-37A71671F69C}</ProjectGuid>
    <OutputType>WinExe</OutputType>
    <RootNamespace>BP_ZalohovaciNastroj</RootNamespace>
    <AssemblyName>BP_ZalohovaciNastroj</AssemblyName>
    <TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>
    <FileAlignment>512</FileAlignment>
    <AutoGenerateBindingRedirects>true</AutoGenerateBindingRedirects>
    <Deterministic>true</Deterministic>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugSymbols>true</DebugSymbols>
    <DebugType>full</DebugType>
    <Optimize>false</Optimize>
    <OutputPath>bin\Debug\</OutputPath>
    <DefineConstants>DEBUG;TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' ">
    <PlatformTarget>AnyCPU</PlatformTarget>
    <DebugType>pdbonly</DebugType>
    <Optimize>true</Optimize>
    <OutputPath>bin\Release\</OutputPath>
    <DefineConstants>TRACE</DefineConstants>
    <ErrorReport>prompt</ErrorReport>
    <WarningLevel>4</WarningLevel>
  </PropertyGroup>
  <ItemGroup>
    <Reference Include="System" />
    <Reference Include="System.Core" />
    <Reference Include="System.Xml.Linq" />
    <Reference Include="System.Data.DataSetExtensions" />
    <Reference Include="Microsoft.CSharp" />
    <Reference Include="System.Data" />
    <Reference Include="System.Deployment" />
    <Reference Include="System.Drawing" />
    <Reference Include="System.Net.Http" />
    <Reference Include="System.Windows.Forms" />
    <Reference Include="System.Xml" />
  </ItemGroup>
  <ItemGroup>
    <Compile Include="View\Backup\BackupResult.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Backup\BackupResult.Designer.cs">
      <DependentUpon>BackupResult.cs</DependentUpon>
    </Compile>
    <Compile Include="View\Recovery\CopyFileDialog.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Recovery\CopyFileDialog.Designer.cs">
      <DependentUpon>CopyFileDialog.cs</DependentUpon>
    </Compile>
    <Compile Include="Extensions.cs" />
    <Compile Include="Filters\AggregationFilter.cs" />
    <Compile Include="Filters\Enums\AggregationOperandEnum.cs" />
    <Compile Include="Filters\AttributeFilter.cs" />
    <Compile Include="Filters\DateTimeFilter.cs" />
    <Compile Include="Filters\Enums\BackUpResultEnum.cs" />
    <Compile Include="Filters\FilePathFilter.cs" />
    <Compile Include="Filters\Filter.cs" />
    <Compile Include="Filters\FilterManager.cs" />
    <Compile Include="View\Backup\Backup.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Backup\Backup.Designer.cs">
      <DependentUpon>Backup.cs</DependentUpon>
    </Compile>
    <Compile Include="View\Projects\NewProjectDialog.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Projects\NewProjectDialog.Designer.cs">
      <DependentUpon>NewProjectDialog.cs</DependentUpon>
    </Compile>
    <Compile Include="View\Main.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Main.Designer.cs">
      <DependentUpon>Main.cs</DependentUpon>
    </Compile>
    <Compile Include="MyFile.cs" />
    <Compile Include="Program.cs" />
    <Compile Include="Project.cs" />
    <Compile Include="Properties\AssemblyInfo.cs" />
    <Compile Include="Filters\SizeFilter.cs" />
    <Compile Include="View\Backup\BackupFilterResult.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Backup\BackupFilterResult.Designer.cs">
      <DependentUpon>BackupFilterResult.cs</DependentUpon>
    </Compile>
    <Compile Include="View\Recovery\Recovery.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Recovery\Recovery.Designer.cs">
      <DependentUpon>Recovery.cs</DependentUpon>
    </Compile>
    <Compile Include="View\Recovery\RecoveryResult.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Recovery\RecoveryResult.Designer.cs">
      <DependentUpon>RecoveryResult.cs</DependentUpon>
    </Compile>
    <Compile Include="View\Projects\ShowProject.cs">
      <SubType>Form</SubType>
    </Compile>
    <Compile Include="View\Projects\ShowProject.Designer.cs">
      <DependentUpon>ShowProject.cs</DependentUpon>
    </Compile>
    <EmbeddedResource Include="View\Backup\BackupResult.resx">
      <DependentUpon>BackupResult.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="View\Backup\Backup.resx">
      <DependentUpon>Backup.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="View\Recovery\CopyFileDialog.resx">
      <DependentUpon>CopyFileDialog.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="View\Projects\NewProjectDialog.resx">
      <DependentUpon>NewProjectDialog.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="View\Main.resx">
      <DependentUpon>Main.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="Properties\Resources.resx">
      <Generator>ResXFileCodeGenerator</Generator>
      <LastGenOutput>Resources.Designer.cs</LastGenOutput>
      <SubType>Designer</SubType>
    </EmbeddedResource>
    <Compile Include="Properties\Resources.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Resources.resx</DependentUpon>
      <DesignTime>True</DesignTime>
    </Compile>
    <EmbeddedResource Include="View\Backup\BackupFilterResult.resx">
      <DependentUpon>BackupFilterResult.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="View\Recovery\Recovery.resx">
      <DependentUpon>Recovery.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="View\Recovery\RecoveryResult.resx">
      <DependentUpon>RecoveryResult.cs</DependentUpon>
    </EmbeddedResource>
    <EmbeddedResource Include="View\Projects\ShowProject.resx">
      <DependentUpon>ShowProject.cs</DependentUpon>
    </EmbeddedResource>
    <None Include="pictures\Anonymous_Pro.ttf" />
    <None Include="Properties\Settings.settings">
      <Generator>SettingsSingleFileGenerator</Generator>
      <LastGenOutput>Settings.Designer.cs</LastGenOutput>
    </None>
    <Compile Include="Properties\Settings.Designer.cs">
      <AutoGen>True</AutoGen>
      <DependentUpon>Settings.settings</DependentUpon>
      <DesignTimeSharedInput>True</DesignTimeSharedInput>
    </Compile>
  </ItemGroup>
  <ItemGroup>
    <None Include="App.config" />
  </ItemGroup>
  <ItemGroup>
    <Content Include="pictures\folder.png" />
  </ItemGroup>
  <ItemGroup />
  <Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" />
</Project>