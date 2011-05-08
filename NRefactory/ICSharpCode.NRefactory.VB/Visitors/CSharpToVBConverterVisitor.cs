﻿// Copyright (c) AlphaSierraPapa for the SharpDevelop Team (for details please see \doc\copyright.txt)
// This code is distributed under the GNU LGPL (for details please see \doc\license.txt)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ICSharpCode.NRefactory.TypeSystem;
using ICSharpCode.NRefactory.VB.Ast;

namespace ICSharpCode.NRefactory.VB.Visitors
{
	public interface IEnvironmentProvider
	{
		string RootNamespace { get; }
		string GetTypeNameForAttribute(CSharp.Attribute attribute);
	}
	
	/// <summary>
	/// Description of CSharpToVBConverterVisitor.
	/// </summary>
	public class CSharpToVBConverterVisitor : CSharp.IAstVisitor<object, VB.AstNode>
	{
		IEnvironmentProvider provider;
		
		public CSharpToVBConverterVisitor(IEnvironmentProvider provider)
		{
			this.provider = provider;
		}
		
		public AstNode VisitAnonymousMethodExpression(CSharp.AnonymousMethodExpression anonymousMethodExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitUndocumentedExpression(CSharp.UndocumentedExpression undocumentedExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitArrayCreateExpression(CSharp.ArrayCreateExpression arrayCreateExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitArrayInitializerExpression(CSharp.ArrayInitializerExpression arrayInitializerExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitAsExpression(CSharp.AsExpression asExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitAssignmentExpression(CSharp.AssignmentExpression assignmentExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitBaseReferenceExpression(CSharp.BaseReferenceExpression baseReferenceExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitBinaryOperatorExpression(CSharp.BinaryOperatorExpression binaryOperatorExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitCastExpression(CSharp.CastExpression castExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitCheckedExpression(CSharp.CheckedExpression checkedExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitConditionalExpression(CSharp.ConditionalExpression conditionalExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitDefaultValueExpression(CSharp.DefaultValueExpression defaultValueExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitDirectionExpression(CSharp.DirectionExpression directionExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitIdentifierExpression(CSharp.IdentifierExpression identifierExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitIndexerExpression(CSharp.IndexerExpression indexerExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitInvocationExpression(CSharp.InvocationExpression invocationExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitIsExpression(CSharp.IsExpression isExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitLambdaExpression(CSharp.LambdaExpression lambdaExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitMemberReferenceExpression(CSharp.MemberReferenceExpression memberReferenceExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitNamedArgumentExpression(CSharp.NamedArgumentExpression namedArgumentExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitNullReferenceExpression(CSharp.NullReferenceExpression nullReferenceExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitObjectCreateExpression(CSharp.ObjectCreateExpression objectCreateExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitAnonymousTypeCreateExpression(CSharp.AnonymousTypeCreateExpression anonymousTypeCreateExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitParenthesizedExpression(CSharp.ParenthesizedExpression parenthesizedExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitPointerReferenceExpression(CSharp.PointerReferenceExpression pointerReferenceExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitPrimitiveExpression(CSharp.PrimitiveExpression primitiveExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitSizeOfExpression(CSharp.SizeOfExpression sizeOfExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitStackAllocExpression(CSharp.StackAllocExpression stackAllocExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitThisReferenceExpression(CSharp.ThisReferenceExpression thisReferenceExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitTypeOfExpression(CSharp.TypeOfExpression typeOfExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitTypeReferenceExpression(CSharp.TypeReferenceExpression typeReferenceExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitUnaryOperatorExpression(CSharp.UnaryOperatorExpression unaryOperatorExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitUncheckedExpression(CSharp.UncheckedExpression uncheckedExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitEmptyExpression(CSharp.EmptyExpression emptyExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryExpression(CSharp.QueryExpression queryExpression, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryContinuationClause(CSharp.QueryContinuationClause queryContinuationClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryFromClause(CSharp.QueryFromClause queryFromClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryLetClause(CSharp.QueryLetClause queryLetClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryWhereClause(CSharp.QueryWhereClause queryWhereClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryJoinClause(CSharp.QueryJoinClause queryJoinClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryOrderClause(CSharp.QueryOrderClause queryOrderClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryOrdering(CSharp.QueryOrdering queryOrdering, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQuerySelectClause(CSharp.QuerySelectClause querySelectClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitQueryGroupClause(CSharp.QueryGroupClause queryGroupClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitAttribute(CSharp.Attribute attribute, object data)
		{
			var attr = new VB.Ast.Attribute();
			
			// TODO : attribute targets
			
			attr.Type = (AstType)attribute.Type.AcceptVisitor(this, data);
//			ConvertNodes(attribute.Arguments, attr.Arguments);
			
			return EndNode(attribute, attr);
		}
		
		public AstNode VisitAttributeSection(CSharp.AttributeSection attributeSection, object data)
		{
			AttributeBlock block = new AttributeBlock();
			ConvertNodes(attributeSection.Attributes, block.Attributes);
			return EndNode(attributeSection, block);
		}
		
		public AstNode VisitDelegateDeclaration(CSharp.DelegateDeclaration delegateDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitNamespaceDeclaration(CSharp.NamespaceDeclaration namespaceDeclaration, object data)
		{
			var newNamespace = new NamespaceDeclaration();
			
			ConvertNodes(namespaceDeclaration.Identifiers, newNamespace.Identifiers);
			ConvertNodes(namespaceDeclaration.Members, newNamespace.Members);
			
			return EndNode(namespaceDeclaration, newNamespace);
		}
		
		public AstNode VisitTypeDeclaration(CSharp.TypeDeclaration typeDeclaration, object data)
		{
			var type = new TypeDeclaration();
			
			CSharp.Attribute stdModAttr;
			
			if (typeDeclaration.ClassType == ClassType.Class && HasAttribute(typeDeclaration.Attributes, "Microsoft.VisualBasic.CompilerServices.StandardModuleAttribute", out stdModAttr)) {
				type.ClassType = ClassType.Module;
				// remove AttributeSection if only one attribute is present
				var attrSec = (CSharp.AttributeSection)stdModAttr.Parent;
				if (attrSec.Attributes.Count == 1)
					attrSec.Remove();
				else
					stdModAttr.Remove();
			} else
				type.ClassType = typeDeclaration.ClassType;
			
			ConvertNodes(typeDeclaration.Attributes, type.Attributes);
			
			type.Name = new Identifier(typeDeclaration.Name, AstLocation.Empty);
			
			return EndNode(typeDeclaration, type);
		}
		
		public AstNode VisitUsingAliasDeclaration(CSharp.UsingAliasDeclaration usingAliasDeclaration, object data)
		{
			var imports = new ImportsStatement();
			
			var clause = new AliasImportsClause() {
				Name = new Identifier(usingAliasDeclaration.Alias, AstLocation.Empty),
				Alias = (AstType)usingAliasDeclaration.Import.AcceptVisitor(this, data)
			};
			
			imports.AddChild(clause, ImportsStatement.ImportsClauseRole);
			
			return EndNode(usingAliasDeclaration, imports);
		}
		
		public AstNode VisitUsingDeclaration(CSharp.UsingDeclaration usingDeclaration, object data)
		{
			var imports = new ImportsStatement();
			
			var clause = new MemberImportsClause() {
				Member = (AstType)usingDeclaration.Import.AcceptVisitor(this, data)
			};
			
			imports.AddChild(clause, ImportsStatement.ImportsClauseRole);
			
			return EndNode(usingDeclaration, imports);
		}
		
		public AstNode VisitExternAliasDeclaration(CSharp.ExternAliasDeclaration externAliasDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitBlockStatement(CSharp.BlockStatement blockStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitBreakStatement(CSharp.BreakStatement breakStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitCheckedStatement(CSharp.CheckedStatement checkedStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitContinueStatement(CSharp.ContinueStatement continueStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitDoWhileStatement(CSharp.DoWhileStatement doWhileStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitEmptyStatement(CSharp.EmptyStatement emptyStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitExpressionStatement(CSharp.ExpressionStatement expressionStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitFixedStatement(CSharp.FixedStatement fixedStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitForeachStatement(CSharp.ForeachStatement foreachStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitForStatement(CSharp.ForStatement forStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitGotoCaseStatement(CSharp.GotoCaseStatement gotoCaseStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitGotoDefaultStatement(CSharp.GotoDefaultStatement gotoDefaultStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitGotoStatement(CSharp.GotoStatement gotoStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitIfElseStatement(CSharp.IfElseStatement ifElseStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitLabelStatement(CSharp.LabelStatement labelStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitLockStatement(CSharp.LockStatement lockStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitReturnStatement(CSharp.ReturnStatement returnStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitSwitchStatement(CSharp.SwitchStatement switchStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitSwitchSection(CSharp.SwitchSection switchSection, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitCaseLabel(CSharp.CaseLabel caseLabel, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitThrowStatement(CSharp.ThrowStatement throwStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitTryCatchStatement(CSharp.TryCatchStatement tryCatchStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitCatchClause(CSharp.CatchClause catchClause, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitUncheckedStatement(CSharp.UncheckedStatement uncheckedStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitUnsafeStatement(CSharp.UnsafeStatement unsafeStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitUsingStatement(CSharp.UsingStatement usingStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitVariableDeclarationStatement(CSharp.VariableDeclarationStatement variableDeclarationStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitWhileStatement(CSharp.WhileStatement whileStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitYieldBreakStatement(CSharp.YieldBreakStatement yieldBreakStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitYieldStatement(CSharp.YieldStatement yieldStatement, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitAccessor(CSharp.Accessor accessor, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitConstructorDeclaration(CSharp.ConstructorDeclaration constructorDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitConstructorInitializer(CSharp.ConstructorInitializer constructorInitializer, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitDestructorDeclaration(CSharp.DestructorDeclaration destructorDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitEnumMemberDeclaration(CSharp.EnumMemberDeclaration enumMemberDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitEventDeclaration(CSharp.EventDeclaration eventDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitCustomEventDeclaration(CSharp.CustomEventDeclaration customEventDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitFieldDeclaration(CSharp.FieldDeclaration fieldDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitIndexerDeclaration(CSharp.IndexerDeclaration indexerDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitMethodDeclaration(CSharp.MethodDeclaration methodDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitOperatorDeclaration(CSharp.OperatorDeclaration operatorDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitParameterDeclaration(CSharp.ParameterDeclaration parameterDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitPropertyDeclaration(CSharp.PropertyDeclaration propertyDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitVariableInitializer(CSharp.VariableInitializer variableInitializer, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitFixedFieldDeclaration(CSharp.FixedFieldDeclaration fixedFieldDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitFixedVariableInitializer(CSharp.FixedVariableInitializer fixedVariableInitializer, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitCompilationUnit(CSharp.CompilationUnit compilationUnit, object data)
		{
			var unit = new CompilationUnit();

			foreach (var node in compilationUnit.Children)
				unit.AddChild(node.AcceptVisitor(this, null), CompilationUnit.MemberRole);
			
			return EndNode(compilationUnit, unit);
		}
		
		public AstNode VisitSimpleType(CSharp.SimpleType simpleType, object data)
		{
			var type = new SimpleType(simpleType.Identifier);
			ConvertNodes(simpleType.TypeArguments, type.TypeArguments);
			
			return EndNode(simpleType, type);
		}
		
		public AstNode VisitMemberType(CSharp.MemberType memberType, object data)
		{
			AstType target = null;
			
			if (memberType.Target is CSharp.SimpleType && ((CSharp.SimpleType)(memberType.Target)).Identifier.Equals("global", StringComparison.Ordinal))
				target = new PrimitiveType("Global");
			else
				target = (AstType)memberType.Target.AcceptVisitor(this, data);
			
			var type = new QualifiedType(target, new Identifier(memberType.MemberName, AstLocation.Empty));
			
			return EndNode(memberType, type);
		}
		
		public AstNode VisitComposedType(CSharp.ComposedType composedType, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitArraySpecifier(CSharp.ArraySpecifier arraySpecifier, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitPrimitiveType(CSharp.PrimitiveType primitiveType, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitComment(CSharp.Comment comment, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitTypeParameterDeclaration(CSharp.TypeParameterDeclaration typeParameterDeclaration, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitConstraint(CSharp.Constraint constraint, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitCSharpTokenNode(CSharp.CSharpTokenNode cSharpTokenNode, object data)
		{
			throw new NotImplementedException();
		}
		
		public AstNode VisitIdentifier(CSharp.Identifier identifier, object data)
		{
			var ident = new Identifier(identifier.Name, ConvertLocation(identifier.StartLocation));
			
			return EndNode(identifier, ident);
		}
		
		public AstNode VisitPatternPlaceholder(CSharp.AstNode placeholder, ICSharpCode.NRefactory.PatternMatching.Pattern pattern, object data)
		{
			throw new NotImplementedException();
		}
		
		void ConvertNodes<T>(IEnumerable<CSharp.AstNode> nodes, VB.AstNodeCollection<T> result) where T : VB.AstNode
		{
			foreach (var node in nodes)
				result.Add((T)node.AcceptVisitor(this, null));
		}
		
		AstLocation ConvertLocation(CSharp.AstLocation location)
		{
			return new AstLocation(location.Line, location.Column);
		}
		
		T EndNode<T>(CSharp.AstNode node, T result) where T : VB.AstNode
		{
			return result;
		}
		
		bool HasAttribute(CSharp.AstNodeCollection<CSharp.AttributeSection> attributes, string name, out CSharp.Attribute foundAttribute)
		{
			foreach (var attr in attributes.SelectMany(a => a.Attributes)) {
				if (provider.GetTypeNameForAttribute(attr) == name) {
					foundAttribute = attr;
					return true;
				}
			}
			foundAttribute = null;
			return false;
		}
	}
}