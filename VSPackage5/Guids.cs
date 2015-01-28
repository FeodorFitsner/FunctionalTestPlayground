// Guids.cs
// MUST match guids.h
using System;

namespace Company.VSPackage5
{
    static class GuidList
    {
        public const string guidVSPackage5PkgString = "e48636e4-efbc-4ec0-8644-9cc83d560100";
        public const string guidVSPackage5CmdSetString = "417ba3fd-716c-4ce9-9e35-9cb88d73706d";
        public const string guidVSPackage5EditorFactoryString = "3465b16c-6743-45de-aef5-6b9e184d0e4e";

        public static readonly Guid guidVSPackage5CmdSet = new Guid(guidVSPackage5CmdSetString);
        public static readonly Guid guidVSPackage5EditorFactory = new Guid(guidVSPackage5EditorFactoryString);
    };
}