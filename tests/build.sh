#!/bin/bash

mcs hello-console.cs
mcs hello-form.cs -pkg:dotnet
mcs hello-gtk.cs -pkg:gtk-sharp-2.0
