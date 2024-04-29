using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CsvHelper;
using ConsoleTables;
using SimpleDecisionTreeLibrary;
using System.Windows;
using Projet_POO2.Models;

namespace Projet_POO2.ViewModels
{
    internal class InProgramViewModel
    {
        public Models.DonneesEntrainementArbre DonneesEntrainementArbre { get; set; }
        private Views.InProgramWindow _inprogramWindow { get; set; }
        private DecisionTree _decisionTree;
        private Node _root;
        private ConfusionMatrix _confusionMatrix;
        public InProgramViewModel(Views.InProgramWindow inprogramWindow)
        {
            _decisionTree = new DecisionTree();
            DonneesEntrainementArbre = new Models.DonneesEntrainementArbre();
            this._inprogramWindow = inprogramWindow;
            EvaluerCommand = new RelayCommand(
                o => DonneesEntrainementArbre.IsValid,
                o => TrainAndEvaluateModel());
        }

        public ICommand EvaluerCommand { get; private set; }
        public void TrainAndEvaluateModel()
        {
            // Construire l'arbre de décision avec les données d'apprentissage
            _root = _decisionTree.BuildTree(DonneesEntrainementArbre.TrainingData);

            // Évaluer le modèle avec les données de test
            DonneesEntrainementArbre.Accuracy = _decisionTree.Evaluate(DonneesEntrainementArbre.TestingData);
            //DisplayConfusionMatrix();

        }
        private void DisplayConfusionMatrix()
        {
            // Évaluer les étiquettes prédites avec les données de test
            List<string[]> testData = SimpleDecisionTreeLibrary.CsvReader.ReadCsvFile(DonneesEntrainementArbre.TestingData).DataRows;
            List<string> predictedLabels = new List<string>();
            foreach (string[] instance in testData)
            {
                string predictedLabel = _decisionTree.Classify(instance);
                predictedLabels.Add(predictedLabel);
            }

            // Obtenir les étiquettes réelles
            List<string> actualLabels = new List<string>();
            foreach (string[] instance in testData)
            {
                actualLabels.Add(instance[instance.Length - 1]);
            }

            // Obtenir les libellés uniques
            List<string> uniqueLabels = actualLabels.Distinct().ToList();

            // Créer une nouvelle instance de ConfusionMatrix
            _confusionMatrix = new ConfusionMatrix(uniqueLabels);

            // Ajouter les résultats à la matrice de confusion
            _confusionMatrix.AddResults(predictedLabels, actualLabels);

            // Afficher la matrice de confusion
            _confusionMatrix.Print();
        }








    }

}

