//Copyright 2025 Pure Light Studio. All Rights Reserved.
//Copyright Hoshino Kennji.

#pragma once
#include "CoreMinimal.h"
#include "Modules\ModuleManager.h"

class FOsmPipeEditorModule:public IModuleInterface
{
public:
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};