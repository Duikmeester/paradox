﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under MIT License. See LICENSE.md for details.
//
//  This file is part of YamlDotNet - A .NET library for YAML.
//  Copyright (c) 2008, 2009, 2010, 2011, 2012, 2013 Antoine Aubry

//  Permission is hereby granted, free of charge, to any person obtaining a copy of
//  this software and associated documentation files (the "Software"), to deal in
//  the Software without restriction, including without limitation the rights to
//  use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
//  of the Software, and to permit persons to whom the Software is furnished to do
//  so, subject to the following conditions:

//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.

//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.

using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace SiliconStudio.Paradox.VisualStudio.Assets
{
	#region Format definition
	[Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = AssetObjectDefinitions.AnchorClassificationName)]
	[Name("Paradox.YamlAnchorFormat")]
	[UserVisible(true)] //this should be visible to the end user
	[Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    [BaseDefinition(PredefinedClassificationTypeNames.SymbolReference)]
	internal sealed class YamlAnchorFormat : ClassificationFormatDefinition
	{
        [ImportingConstructor]
        public YamlAnchorFormat(AssetObjectClassificationColorManager colorManager)
		{
			DisplayName = "Paradox YAML Anchor"; //human readable version of the name
            var classificationColor = colorManager.GetClassificationColor(AssetObjectDefinitions.AnchorClassificationName);
            ForegroundColor = classificationColor.ForegroundColor;
            BackgroundColor = classificationColor.BackgroundColor;
		}
	}

	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = AssetObjectDefinitions.AliasClassificationName)]
    [Name("Paradox.YamlAliasFormat")]
    [UserVisible(true)] //this should be visible to the end user
	[Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    [BaseDefinition(PredefinedClassificationTypeNames.Literal)]
	internal sealed class YamlAliasFormat : ClassificationFormatDefinition
	{
        [ImportingConstructor]
        public YamlAliasFormat(AssetObjectClassificationColorManager colorManager)
		{
            DisplayName = "Paradox YAML Alias"; //human readable version of the name
            var classificationColor = colorManager.GetClassificationColor(AssetObjectDefinitions.AliasClassificationName);
            ForegroundColor = classificationColor.ForegroundColor;
            BackgroundColor = classificationColor.BackgroundColor;
        }
	}

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = AssetObjectDefinitions.KeyClassificationName)]
    [Name("Paradox.YamlKeyFormat")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    [BaseDefinition(PredefinedClassificationTypeNames.Keyword)]
    internal sealed class YamlKeyFormat : ClassificationFormatDefinition
    {
        [ImportingConstructor]
        public YamlKeyFormat(AssetObjectClassificationColorManager colorManager)
        {
            DisplayName = "Paradox YAML Key"; //human readable version of the name
            var classificationColor = colorManager.GetClassificationColor(AssetObjectDefinitions.KeyClassificationName);
            ForegroundColor = classificationColor.ForegroundColor;
            BackgroundColor = classificationColor.BackgroundColor;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = AssetObjectDefinitions.NumberClassificationName)]
    [Name("Paradox.YamlNumberFormat")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    [BaseDefinition(PredefinedClassificationTypeNames.Number)]
    internal sealed class YamlNumberFormat : ClassificationFormatDefinition
    {
        [ImportingConstructor]
        public YamlNumberFormat(AssetObjectClassificationColorManager colorManager)
        {
            DisplayName = "Paradox YAML Number"; //human readable version of the name
            var classificationColor = colorManager.GetClassificationColor(AssetObjectDefinitions.NumberClassificationName);
            ForegroundColor = classificationColor.ForegroundColor;
            BackgroundColor = classificationColor.BackgroundColor;
        }
    }

    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = AssetObjectDefinitions.ErrorClassificationName)]
    [Name("Paradox.YamlErrorFormat")]
    [UserVisible(true)] //this should be visible to the end user
    [Order(Before = Priority.Default)] //set the priority to be after the default classifiers
    [BaseDefinition(PredefinedClassificationTypeNames.Other)]
    internal sealed class YamlErrorFormat : ClassificationFormatDefinition
    {
        [ImportingConstructor]
        public YamlErrorFormat(AssetObjectClassificationColorManager colorManager)
        {
            DisplayName = "Paradox YAML Error"; //human readable version of the name
            var classificationColor = colorManager.GetClassificationColor(AssetObjectDefinitions.ErrorClassificationName);
            ForegroundColor = classificationColor.ForegroundColor;
            BackgroundColor = classificationColor.BackgroundColor;
        }
    }
	#endregion //Format definition
}
