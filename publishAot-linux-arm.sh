#!/bin/bash
dotnet publish -r linux-arm -c Release -p:PublishAot=true -p:LinkerFlavor=lld