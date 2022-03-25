﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace JCA.AutomatedTests.Wemobi.User_Password_Reset
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;


    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class EsqueciMinhaSenha_UsuarioFeature : object, Xunit.IClassFixture<EsqueciMinhaSenha_UsuarioFeature.FixtureData>, System.IDisposable
    {

        private static TechTalk.SpecFlow.ITestRunner testRunner;

        private string[] _featureTags = ((string[])(null));

        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;

#line 1 "ResetDeSenhaBDD.feature"
#line hidden

        public EsqueciMinhaSenha_UsuarioFeature(EsqueciMinhaSenha_UsuarioFeature.FixtureData fixtureData, JCA_AutomatedTests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }

        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Wemobi/User_Password_Reset", "Esqueci minha senha - Usuário", "Como um usuário\r\nEu desejo realizar o reset de senha no Wemobi\r\nPara que eu possa" +
                    " acessar a plataforma novamente", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }

        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }

        public virtual void TestInitialize()
        {
        }

        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }

        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }

        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }

        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }

        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }

        [Xunit.SkippableFactAttribute(DisplayName = "Realizar reset de senha com sucesso")]
        [Xunit.TraitAttribute("FeatureTitle", "Esqueci minha senha - Usuário")]
        [Xunit.TraitAttribute("Description", "Realizar reset de senha com sucesso")]
        public virtual void RealizarResetDeSenhaComSucesso()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Realizar reset de senha com sucesso", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
            this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
                testRunner.Given("O usuário acesse o Website", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
#line 8
                testRunner.And("Clica em Entrar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 9
                testRunner.And("Clica em link esqueci minha senha", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 10
                testRunner.And("Sistema direciona para o formulário", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 11
                testRunner.And("Usuário preenche campos e clica em botão Enviar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line hidden
#line 12
                testRunner.Then("Sistema envia a nova senha com sucesso", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            }
            this.ScenarioCleanup();
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {

            public FixtureData()
            {
                EsqueciMinhaSenha_UsuarioFeature.FeatureSetup();
            }

            void System.IDisposable.Dispose()
            {
                EsqueciMinhaSenha_UsuarioFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion