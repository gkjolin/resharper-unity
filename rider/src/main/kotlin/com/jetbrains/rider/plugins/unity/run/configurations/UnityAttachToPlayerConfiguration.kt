package com.jetbrains.rider.plugins.unity.run.configurations

import com.intellij.icons.AllIcons
import com.jetbrains.rider.plugins.unity.util.UnityIcons
import com.jetbrains.rider.run.configurations.remote.RemoteConfiguration
import javax.swing.Icon

class UnityAttachToPlayerConfiguration(private val configurationName : String, debuggerPort : Int, host: String = "127.0.0.1") : RemoteConfiguration {
    override var port: Int = debuggerPort
    override var address: String = host
    override var listenPortForConnections: Boolean = false

    override fun getName(): String {
        return configurationName
    }

    override fun getIcon(): Icon {
        return UnityIcons.AttachEditorDebugConfiguration
    }
}