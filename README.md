# Templates - Dotnet

[![Build Status](https://dev.azure.com/kritikos/DotNet%20Libaries/_apis/build/status/Extensions.Primitive?branchName=master)](https://dev.azure.com/kritikos/DotNet%20Libaries/_build/latest?definitionId=11&branchName=master)
[![Coverage Status](https://coveralls.io/repos/github/kritikos-io/Extensions.Primitive/badge.svg?branch=master)](https://coveralls.io/github/kritikos-io/Extensions.Primitive?branch=master)
[![codecov](https://codecov.io/gh/kritikos-io/Extensions.Primitive/branch/master/graph/badge.svg)](https://codecov.io/gh/kritikos-io/Extensions.Primitive)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=kritikos-io_Extensions.Primitive&metric=alert_status)](https://sonarcloud.io/dashboard?id=kritikos-io_Extensions.Primitive)
[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
![GitHub language count](https://img.shields.io/github/languages/count/kritikos-io/Extensions.Primitive)
![GitHub top language](https://img.shields.io/github/languages/top/kritikos-io/Extensions.Primitive)

Simple extension methods over primitive .NET types, to avoid creating them in every project.

Current methods include:

- String
  - IsNullOrEmpty
  - IsNullOrWhiteSpace
  - AsSecureString
- SecureString
  - UnsecureString
- Unsigned integer types (uint, ulong, ushort)
  - ReverseBytes (changes endianess)
- DateTime/DateTimeOffset
  - To/From unix epoch time
